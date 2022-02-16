export const loadingPendingReducer = (property, defaultState) => state => {
    if (!state[property] && defaultState)
        state[property] = { model: defaultState };
    startLoading(state, property);
};
export const loadingRejectedReducer = property => state => {
    endLoading(state, property);
};
export const loadingFulfilledReducer = property => (state, action) => {
    state[property].model = action.payload;
    endLoading(state, property);
};
const startLoading = (state, property) => state[property].loading = true;
const endLoading = (state, property) => state[property].loading = false;

const getStateStr = property => `state${property.split(".").map(p => `["${p}"]`).join("")}`;
/* eslint no-eval: 0 */
export const assigningReducer = property => (state, action) => {
    const stateStr = getStateStr(property);
    eval(`${stateStr} = action.payload;`);
};
/* eslint no-eval: 0 */
export const assigningSpreadObjReducer = property => (state, action) => {
    const stateStr = getStateStr(property);
    eval(`${stateStr} = { ...${stateStr}, ...action.payload };`);
};
/* eslint no-eval: 0 */
export const assigningSpreadArrayReducer = property => (state, action) => {
    const stateStr = getStateStr(property);
    eval(`${stateStr} = [...${stateStr}, ...action.payload];`);
};