import { configureStore } from '@reduxjs/toolkit';
import authStore from './auth';

const devMode = process.env.REACT_APP_ENVIRONMENT === 'development';

export default configureStore({
    reducer: {
        auth: authStore.reducer,
    },
    middleware: (getDefaultMiddleware) => [...getDefaultMiddleware()],
    devTools: devMode,
});

export {
    authStore,
};