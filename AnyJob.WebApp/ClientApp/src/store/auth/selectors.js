import { sliceName } from "./shared";

const selectors = {
    selectUser: store => store[sliceName].value,
    selectUserBookmarks: store => store[sliceName].value.bookmarks,
};

export default selectors;