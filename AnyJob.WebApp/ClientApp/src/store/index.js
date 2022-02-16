import { configureStore } from '@reduxjs/toolkit';
import authStore from './auth';
import searchStore from './search';

const devMode = process.env.REACT_APP_ENVIRONMENT === 'development';

export default configureStore({
    reducer: {
        auth: authStore.reducer,
        search: searchStore.reducer,
    },
    middleware: (getDefaultMiddleware) => [...getDefaultMiddleware()],
    devTools: devMode,
});

export {
    authStore,
    searchStore,
};