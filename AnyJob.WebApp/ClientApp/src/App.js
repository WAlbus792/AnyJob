import React, { useEffect } from 'react';
import { Router, Route, Switch, Redirect } from 'react-router';
import { history } from "./utils";
import { Layout } from './components/Layout';
import { JobPostings } from "./pages";
import { useDispatch } from "react-redux";
import { authStore } from "./store";

function App() {
  const dispatch = useDispatch();
  
  useEffect(() => {
    dispatch(authStore.loadCurrentUser());
  }, [dispatch]);
  
  return (
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
  );
}

export default App;