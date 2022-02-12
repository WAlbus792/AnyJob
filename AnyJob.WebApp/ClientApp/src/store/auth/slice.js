import { createSlice } from '@reduxjs/toolkit';
import { thunks } from "./actions";
import reducers, { extraReducers } from "./reducers";
import { sliceName } from "./shared";

const initialState = {
    value: null,
};
const slice = createSlice({
    name: sliceName,
    initialState,
    reducers,
    extraReducers: builder => {
        builder
            .addCase(thunks.loadAnonymousUser.fulfilled, extraReducers.loadUserFulfilled)
            .addCase(thunks.loadAnonymousUser.rejected, extraReducers.loadUserRejected);
    },
});

export default slice;
