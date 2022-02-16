import { userSessionProvider } from "../../utils";

function defaultValue() {
    return { anonymousId: userSessionProvider.getAnonymousId(), bookmarks: [] };
}

const reducers = {};

export const extraReducers = {
    loadUserFulfilled(state, action) {
        state.value = action.payload ?? defaultValue();
    },
    loadUserRejected(state) {
        state.value = defaultValue();
    },
}

export default reducers;