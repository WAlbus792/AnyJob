import { sliceName } from "./shared";

const selectors = {
    selectCategories: store => store[sliceName].categories,
    selectLocations: store => store[sliceName].locations,
    selectEmploymentTypes: store => store[sliceName].employmentTypes,
    
    selectSearchTitle: store => store[sliceName].searchTitle,
    
    selectSearchBoxCategory: store => store[sliceName].searchBoxOptions.category,
    selectSearchBoxLocation: store => store[sliceName].searchBoxOptions.location,
    selectSearchBoxOptions: store => store[sliceName].searchBoxOptions,
    
    selectAdvancedFiltersCategories: store => store[sliceName].advancedFilters.categories,
    selectAdvancedFiltersLocations: store => store[sliceName].advancedFilters.locations,
    selectAdvancedFiltersEmploymentTypes: store => store[sliceName].advancedFilters.employmentTypes,
    selectAdvancedFilters: store => store[sliceName].advancedFilters,
    
    selectTableOptions: store => ({
        sortBy: store[sliceName].sortBy,
        page: store[sliceName].page,
        pageSize: store[sliceName].pageSize,
    }),
    
    selectJobPostings: store => store[sliceName].jobPostings,
    selectDataInitialized: store => !!store[sliceName].jobPostings,
};

export default selectors;