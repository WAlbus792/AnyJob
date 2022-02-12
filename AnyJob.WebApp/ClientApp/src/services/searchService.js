import axios from './axiosBase';

const searchService = {
    getCategories: () => axios.get('Categories'),
    getLocations: () => axios.get('Locations'),
    getEmploymentTypes: () => axios.get('EmploymentTypes'),
    getJobPostings: data => axios.post('JobPostings', data),
    bookmarkJobPosting: id => axios.put(`JobPostings/${id}`),
};
export default searchService;