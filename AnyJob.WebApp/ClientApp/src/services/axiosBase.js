import axios from "axios";
import { toast, userSessionProvider } from "../utils";

const IS_LOCALHOST = document.location.origin.includes('localhost');

axios.defaults.baseURL = `${process.env.REACT_APP_URL}/api/`;
axios.defaults.headers['Content-Type'] = 'application/json';
axios.defaults.headers['Accept'] = "application/json";

function authorize(headers) {
  const anonymousId = userSessionProvider.getAnonymousId();
  if (anonymousId) headers['AnonymousId'] = anonymousId;
}

axios.defaults.transformRequest = [
  function (data, headers) {
    authorize(headers);
    return headers['Content-Type'] === 'application/json' ? JSON.stringify(data) : data;
  },
];

axios.interceptors.response.use(response => response.data, error => {
  if (error.response) {
    const errorMessage = getErrorMessage(error);
    toast.error(errorMessage);
    return Promise.reject(errorMessage);
  }
  
  return Promise.reject("Internal Server Error");
});

const getErrorMessage = error => {
  const data = error.response.data;
  if (IS_LOCALHOST)
    console.error(data);
  else if (error.response.status === 500)
    return "Internal Server Error";
  
  return data.message;
};

export default axios;