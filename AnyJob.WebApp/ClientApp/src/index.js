// import "./utils/primitives/prototypes";
import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import store from './store';
import { Provider } from "react-redux";
import reportWebVitals from './reportWebVitals';
import { ToastSnackbarProvider } from "./utils/toast";
import './index.scss';

ReactDOM.render(
  <React.StrictMode>
    <ToastSnackbarProvider />
    <Provider store={store}>
      <App />
    </Provider>
  </React.StrictMode>,
  document.getElementById('root'),
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();

