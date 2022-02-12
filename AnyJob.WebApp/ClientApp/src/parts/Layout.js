import React from 'react';
import { Container } from "@mui/material";
import { makeStyles } from "@mui/styles";

export default function Layout(props) {
    const classes = useStyles();
    
    return (
        <Container className={classes.root}>
            {props.children}
        </Container>
    );
}

const useStyles = makeStyles(theme => ({
    root: {
        paddingTop: 100,
    },
}));
