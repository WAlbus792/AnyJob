import axios from './axiosBase';

const searchService = {
    getCategories: () => axios.get('Categories'),
    getLocations: () => axios.get('Locations'),
    getEmploymentTypes: () => axios.get('EmploymentTypes'),
    getJobPostings: data => axios.post('Search', data),
};
export default searchService;