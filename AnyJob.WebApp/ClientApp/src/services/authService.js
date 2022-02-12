import axios from './axiosBase';

const authService = {
  getAnonymousUser: () => axios.get('Auth/Anonymous'),
}
export default authService;