import React, { useEffect } from 'react';
import { Router, Route, Switch, Redirect } from 'react-router';
import { history } from "./utils";
import { Layout } from './parts';
import { JobPostings } from "./pages";
import { useDispatch } from "react-redux";
import { authStore } from "./store";
import { createTheme, ThemeProvider } from "@mui/material";

import 'react-block-ui/style.css';
import 'loaders.css/loaders.min.css';

export default function App() {
    const dispatch = useDispatch();
    
    useEffect(() => {
        dispatch(authStore.loadCurrentUser());
    }, [dispatch]);
    
    return (
        <ThemeProvider theme={theme}>
            <Layout>
                <Router history={history}>
                    <Switch>
                        <Route path="/job-postings" component={JobPostings} />
                        <Route path="/details" component={JobPostings} />
                        <Route path="/*">
                            <Redirect to="/job-postings" />
                        </Route>
                    </Switch>
                </Router>
            </Layout>
        </ThemeProvider>
    );
}

const theme = createTheme({
    palette: {
        primary: {
            main: '#102434',
        },
    },
    props: {
        MuiButton: {
            disableElevation: true,
        },
    },
});
