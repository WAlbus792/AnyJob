import React from 'react';
import { FormControl, Grid, MenuItem, Pagination, Paper, Select, Typography } from "@mui/material";
import { useDispatch, useSelector } from "react-redux";
import JobPostingDataItem from "./JobPostingDataItem";
import { searchStore } from "../../store";
import { makeStyles } from "@mui/styles";
import { SortBy } from "../../utils/constants";

export default function JobPostingDataTable() {
    const jobPostings = useSelector(searchStore.selectJobPostings);
    const tableOptions = useSelector(searchStore.selectTableOptions);
    const dispatch = useDispatch();
    const classes = useStyles();
    
    function changeHandler(reducer, value) {
        dispatch(searchStore[reducer](value))
        dispatch(searchStore.getJobPostings());
    }
    
    return (
        <Paper className={classes.root}>
            <Grid container justifyContent="space-between" alignItems="center" p={3}>
                <Grid item>
                    <Typography gutterBottom={false}>
                        <strong>
                            {jobPostings.total
                                ? `Showing ${(tableOptions.page - 1) * tableOptions.pageSize + 1}
                                - ${tableOptions.page * tableOptions.pageSize > jobPostings.total ? jobPostings.total : tableOptions.page * tableOptions.pageSize } of ${jobPostings.total} offers`
                                : 'There are no offers'}
                        </strong>
                    </Typography>
                </Grid>
                <Grid item className={classes.sort} display="flex">
                    <Grid item>
                        <Typography variant="body 1">Sort by:</Typography>
                    </Grid>
                    <Grid item>
                        <FormControl variant="outlined" size="small" fullWidth>
                            <Select
                                value={tableOptions.sortBy}
                                onChange={e => changeHandler("setSortBy", e.target.value)}
                            >
                                {SortBy.map(s => <MenuItem key={s.id} value={s}>{s.name}</MenuItem>)}
                            </Select>
                        </FormControl>
                    </Grid>
                </Grid>
            </Grid>
            
            <Pagination
                count={Math.floor(jobPostings.total / 10)}
                shape="rounded"
                showFirstButton
                page={tableOptions.page}
                onChange={(_, p) => changeHandler("setPage", p)}
                showLastButton
                className={classes.pagination}
                
            />
            
            <Grid container p={3}>
                {jobPostings.data.map(p => (
                    <Grid key={p.id} item className={`${classes.item} job-item`}>
                        <JobPostingDataItem data={p} />
                    </Grid>
                ))}
            </Grid>
        </Paper>
    );
}

const useStyles = makeStyles(theme => ({
    root: {},
    sort: {
        // display: 'flex',
        alignItems: 'center',
        
        '& > .MuiGrid-root:first-child': {
            paddingRight: theme.spacing(1),
        },
    },
    pagination: {
        paddingLeft: theme.spacing(3),
        paddingRight: theme.spacing(3),
        
        '& > ul': {
            justifyContent: 'end',
        },
    },
    item: {
        width: '100%',
        
        '&.job-item+.job-item': {
            marginTop: theme.spacing(2),
        },
    },
}));