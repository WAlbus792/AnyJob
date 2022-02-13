import React, { useState } from 'react';
import ReactDOM from "react-dom";
import { Slide, Snackbar } from "@mui/material";
import MuiAlert from "@mui/material/Alert";

const toastSnackbarEl = document.getElementById('toast-snackbar');

let toastSnackbar;

const Alert = React.forwardRef(function Alert(props, ref) {
  return <MuiAlert elevation={6} ref={ref} sx={{ width: '100%' }} variant="filled" {...props} />;
});
const defaultState = { open: false, message: "", variant: "" };
const ToastSnackbar = () => {
  const [state, setState] = useState({ ...defaultState });
  
  const handleClick = (message, variant) => setState({ open: true, message, variant });
  
  const handleClose = (event, reason) => {
    if (reason === 'clickaway') return;
    
    setState(prevState => ({ ...defaultState, variant: prevState.variant }));
  };
  
  toastSnackbar = { handleClick };
  
  return (
    <Snackbar
      anchorOrigin={{ vertical: "bottom", horizontal: "right" }}
      open={state.open}
      autoHideDuration={5000}
      resumeHideDuration={3000}
      onClose={handleClose}
      TransitionComponent={props => <Slide {...props} direction="left" />}
    >
      <Alert onClose={handleClose} severity={state.variant}>
        {state.message}
      </Alert>
    </Snackbar>
  );
};

const ToastSnackbarProvider = () => ReactDOM.createPortal(
  <ToastSnackbar />,
  toastSnackbarEl,
);

function createToast() {
  const show = (msg, variant) => toastSnackbar.handleClick(msg, variant);
  
  return {
    success: msg => show(msg, 'success'),
    warning: msg => show(msg, 'warning'),
    info: msg => show(msg, 'info'),
    error: msg => show(msg, 'error'),
  };
}

const toast = createToast();

export { ToastSnackbarProvider };
export default toast;