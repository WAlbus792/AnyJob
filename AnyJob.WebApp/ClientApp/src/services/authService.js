import axios from './axiosBase';

const authService = {
  getAnonymousUser: () => axios.get('Auth/GetAnonymous'),
}
export default authService;