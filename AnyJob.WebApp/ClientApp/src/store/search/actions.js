import { createAsyncThunk } from "@reduxjs/toolkit";
import { searchService } from "../../services";
import { sliceName } from "./shared";
import selectors from "./selectors";
import { withThrow } from "../shared/reduxExtensions";
import searchStore from "./index";
import authStore from "../auth";

const thunkActions = {
    getCategories: createAsyncThunk(`${sliceName}/getCategories`, searchService.getCategories),
    getLocations: createAsyncThunk(`${sliceName}/getLocations`, searchService.getLocations),
    getEmploymentTypes: createAsyncThunk(`${sliceName}/getEmploymentTypes`, searchService.getEmploymentTypes),
};

const actions = {
    ...thunkActions,
    
    initFilters: () => dispatch => {
        dispatch(thunkActions.getCategories());
        dispatch(thunkActions.getLocations());
        dispatch(thunkActions.getEmploymentTypes());
    },
    getJobPostings: () => async (dispatch, getState) => {
        const state = getState();
    
        const dataInitialized = selectors.selectDataInitialized(state);
        const filters = { searchTitle: selectors.selectSearchTitle(state) };
        if (!dataInitialized) {
            const searchBoxOptions = selectors.selectSearchBoxOptions(state);
            if (searchBoxOptions.category)
                filters.categories = [searchBoxOptions.category.id];
            if (searchBoxOptions.location)
                filters.locations = [searchBoxOptions.location.id];
        } else {
            const advancedFilters = selectors.selectAdvancedFilters(state);
            filters.categories = advancedFilters.categories;
            filters.locations = advancedFilters.locations;
            filters.employmentTypes = advancedFilters.employmentTypes;
        }
        const tableOptions = selectors.selectTableOptions(state);
    
        const response = await withThrow(dispatch(thunks.getJobPostings({ ...filters, ...tableOptions, sortBy: tableOptions.sortBy.id })));
        const jobPostings = response.payload;
        if (tableOptions.page * tableOptions.pageSize > jobPostings.total)
            dispatch(searchStore.setPage(Math.floor(jobPostings.total / tableOptions.pageSize) + 1));
    },
    bookmarkJobPosting: id => async dispatch => {
        await withThrow(dispatch(thunks.bookmarkJobPosting(id)));
        dispatch(authStore.addToBookmarks(id));
    }
};

const thunks = {
    ...thunkActions,
    
    getJobPostings: createAsyncThunk(`${sliceName}/getJobPostings`, searchService.getJobPostings),
    bookmarkJobPosting: createAsyncThunk(`${sliceName}/bookmarkJobPosting`, searchService.bookmarkJobPosting),
};

export default actions;
export { thunks };