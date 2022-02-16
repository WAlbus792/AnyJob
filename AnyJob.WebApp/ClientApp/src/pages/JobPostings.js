import React, { useEffect } from 'react';
import { Box, Grid } from "@mui/material";
import { AdvancedFilters, JobPostingDataTable, SearchBox } from "../components/JobPostings";
import { makeStyles } from "@mui/styles";
import { searchStore } from "../store";
import { useDispatch, useSelector } from "react-redux";

export default function JobPostings() {
    const classes = useStyles();
    const dataInitialized = useSelector(searchStore.selectDataInitialized);
    const dispatch = useDispatch();
    
    useEffect(() => {
        dispatch(searchStore.initFilters());
    }, [dispatch]);
    
    return (
        <Box className={classes.root}>
            <SearchBox />
            
            {dataInitialized ? (
                <Grid container className="content" spacing={2}>
                    <Grid item xs={3.5}>
                        <AdvancedFilters />
                    </Grid>
                    <Grid item xs={8.5}>
                        <JobPostingDataTable />
                    </Grid>
                </Grid>
            ) : null}
        
        </Box>
    );
};

const useStyles = makeStyles(theme => ({
    root: {
        '& > .content': {
            marginTop: theme.spacing(3),
        },
    },
}));