const reducers = {
    setSearchBoxCategory(state, action) {
        state.searchBoxOptions.category = action.payload;
    },
    setSearchBoxLocation(state, action) {
        state.searchBoxOptions.location = action.payload;
    },
    setSearchTitle(state, action) {
        state.searchTitle = action.payload;
    },
    setSortBy(state, action) {
        state.sortBy = action.payload;
    },
    setPage(state, action) {
        state.page = action.payload;
    },
    
    setAdvancedFiltersCategories(state, action) {
        state.advancedFilters.categories = action.payload;
    },
    setAdvancedFiltersLocations(state, action) {
        state.advancedFilters.locations = action.payload;
    },
    setAdvancedFiltersEmploymentTypes(state, action) {
        state.advancedFilters.employmentTypes = action.payload;
    },
};
export const extraReducers = {};

export default reducers;