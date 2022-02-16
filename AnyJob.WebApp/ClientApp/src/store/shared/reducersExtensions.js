export const loadingPendingReducer = property => state => {
    startLoading(state, property);
};
export const loadingRejectedReducer = property => state => {
    endLoading(state, property);
};
export const loadingFulfilledReducer = (property, dataProcessor) => (state, action) => {
    let data = action.payload;
    if (dataProcessor)
        data = dataProcessor(data);
    
    state[property].data = data;
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
    eval(`${stateStr} = [ ...${stateStr}, ...action.payload ];`);
};