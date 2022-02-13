import { createSlice } from '@reduxjs/toolkit';
import { thunks } from "./actions";
import reducers from "./reducers";

const initialState = {
    value: null,
};

export const slice = createSlice({
    name: 'auth',
    initialState,
    reducers: {},
    extraReducers: builder => {
        builder
            .addCase(thunks.loadAnonymousUser.fulfilled, reducers.loadUserFulfilled)
            .addCase(thunks.loadAnonymousUser.rejected, reducers.loadUserRejected);
    },
});
