import React from 'react';
import { Box, Button, Grid, TextField } from "@mui/material";
import CategorySelect from "./CategorySelect";
import LocationSelect from "./LocationSelect";
import { searchStore } from "../../../store";
import { useDispatch, useSelector } from "react-redux";
import { makeStyles } from "@mui/styles";

export default function SearchBox() {
    const classes = useStyles();
    const searchTitle = useSelector(searchStore.selectSearchTitle);
    const dataInitialized = useSelector(searchStore.selectDataInitialized);
    const dispatch = useDispatch();
    
    function search() {
        dispatch(searchStore.getJobPostings());
    }
    
    return (
        <Box className={classes.box}>
            <Grid container className={classes.container}>
                {
                    !dataInitialized ? (
                        <>
                            <Grid item xs={3}>
                                <CategorySelect />
                            </Grid>
                            <Grid item xs={3}>
                                <LocationSelect />
                            </Grid>
                        </>
                    ) : null
                }
                <Grid item xs={!dataInitialized ? 4.5 : 10.5}>
                    <TextField
                        value={searchTitle}
                        className={classes.searchTitle}
                        variant="filled"
                        placeholder="Type your keyword"
                        onChange={e => dispatch(searchStore.setSearchTitle(e.target.value))}
                        onKeyPress={e => e.key === "Enter" ? search() : null}
                    />
                </Grid>
                <Grid item xs={1.5}>
                    <Button
                        variant="contained"
                        color="primary"
                        className={classes.searchBtn}
                        onClick={search}
                    >
                        Search
                    </Button>
                </Grid>
            </Grid>
        </Box>
    );
};
const useStyles = makeStyles(theme => ({
    box: {
        borderRadius: 5,
        background: 'rgba(0, 0, 0, 0.4)',
        padding: theme.spacing(2),
    },
    container: {
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 5,
        background: 'rgb(255, 255, 255)',
    },
    searchTitle: {
        width: '100%',
        '& input': {
            paddingTop: 0,
            paddingBottom: 0,
            height: 48,
        },
    },
    searchBtn: {
        'button&': {
            height: 48,
            width: '100%',
            borderTopLeftRadius: 0,
            borderBottomLeftRadius: 0,
        },
    },
}));