import { createSlice } from '@reduxjs/toolkit';
import { thunks } from "./actions";
import { assigningReducer } from "../shared/reducersExtensions";
import reducers from "./reducers";
import { sliceName } from "./shared";
import { SortBy } from "../../utils/constants";

const initialState = {
    categories: [],
    locations: [],
    employmentTypes: [],
    searchBoxOptions: {
        category: null,
        location: null,
    },
    searchTitle: "",
    
    advancedFilters: {
        categories: [],
        locations: [],
        employmentTypes:  [],
    },
    
    // table options
    page: 1,
    pageSize: 10,
    sortBy: SortBy[0],
    
    jobPostings: null
};
const slice = createSlice({
    name: sliceName,
    initialState,
    reducers,
    extraReducers: builder => {
        builder
            .addCase(thunks.getCategories.fulfilled, assigningReducer("categories"))
            .addCase(thunks.getLocations.fulfilled, assigningReducer("locations"))
            .addCase(thunks.getEmploymentTypes.fulfilled, assigningReducer("employmentTypes"))
            .addCase(thunks.getJobPostings.fulfilled, assigningReducer("jobPostings"));
    },
});

export default slice;