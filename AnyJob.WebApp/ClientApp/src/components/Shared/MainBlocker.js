import React from 'react';
import BlockUi from "react-block-ui";
import Loader from 'react-loaders';
import { makeStyles } from "@mui/styles";

const MainBlocker = ({ blocking, children, className }) => {
    const classes = useStyles();
    let classNames = classes.blockUi;
    if (className)
        classNames += ` ${className}`;
    
    return (
        <BlockUi
            tag="div"
            className={classNames}
            blocking={blocking}
            loader={<Loader active type="ball-beat" innerClassName={classes.innerLoader} color="#102434" />}
        >
            {children}
        </BlockUi>
    );
};

const useStyles = makeStyles(theme => ({
    blockUi: {
        '& .block-ui-overlay': {
            opacity: 0.7,
        },
        '& .block-ui-container': {
            minHeight: "auto",
        },
    },
    innerLoader: {
        display: 'inline-block',
    },
    
}));

export default MainBlocker;