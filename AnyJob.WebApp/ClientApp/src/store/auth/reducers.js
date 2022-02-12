import { userSessionProvider } from "../../utils";
import _ from "lodash";

function defaultValue() {
    return { anonymousId: userSessionProvider.getAnonymousId(), bookmarks: [] };
}

const reducers = {
    addToBookmarks(state, action) {
        if (state.value.bookmarks.includes(action.payload))
            _.remove(state.value.bookmarks, b => b === action.payload);
        else state.value.bookmarks.push(action.payload);
    },
};

export const extraReducers = {
    loadUserFulfilled(state, action) {
        state.value = action.payload ?? defaultValue();
    },
    loadUserRejected(state) {
        state.value = defaultValue();
    },
};

export default reducers;