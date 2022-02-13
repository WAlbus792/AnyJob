export async function withThrow(dispatchFunc) {
    const response = await dispatchFunc;
    
    if (response.error)
        throw response.error;
    
    return response;
}