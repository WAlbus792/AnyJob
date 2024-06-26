import { createAsyncThunk } from "@reduxjs/toolkit";
import { authService } from "../../services";
import { userSessionProvider } from "../../utils";
import { sliceName } from "./shared";

const thunkActions = {
    // action + thunk as one function
};

const actions = {
    ...thunkActions,
    
    loadCurrentUser: () => dispatch => {
        let key = userSessionProvider.getAnonymousId();
        if (!key) userSessionProvider.startSession();
        
        dispatch(thunks.loadAnonymousUser());
        
    },
};

const thunks = {
    ...thunkActions,
    
    loadAnonymousUser: createAsyncThunk(`${sliceName}/loadAnonymousUser`, authService.getAnonymousUser),
};

export default actions;
export { thunks };