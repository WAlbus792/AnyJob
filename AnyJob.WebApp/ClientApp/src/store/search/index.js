import slice from "./slice";
import actions from "./actions";
import selectors from './selectors';

const searchStore = {
    reducer: slice.reducer,
    ...slice.actions,
    ...actions,
    ...selectors,
};

export default searchStore;