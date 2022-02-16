import { loadingFulfilledReducer, loadingPendingReducer, loadingRejectedReducer } from "./reducersExtensions";

export const addFull = (builder, thunk, property, defaultState) => builder
    .addCase(thunk.pending, loadingPendingReducer(property, defaultState))
    .addCase(thunk.fulfilled, loadingFulfilledReducer(property))
    .addCase(thunk.rejected, loadingRejectedReducer(property));
