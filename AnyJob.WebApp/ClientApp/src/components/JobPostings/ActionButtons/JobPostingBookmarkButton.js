import React from 'react';
import { Button } from "@mui/material";
import BookmarkIcon from "@mui/icons-material/Bookmark";
import BookmarkBorderIcon from "@mui/icons-material/BookmarkBorder";
import { useDispatch, useSelector } from "react-redux";
import { authStore, searchStore } from "../../../store";
import { makeStyles } from "@mui/styles";

export default function JobPostingBookmarkButton({ id }) {
    const classes = useStyles();
    const dispatch = useDispatch();
    const bookmarks = useSelector(authStore.selectUserBookmarks);
    const isBookmarked = bookmarks.includes(id);
    
    return (
        <Button className={classes.button} variant="contained" color="primary" onClick={() => dispatch(searchStore.bookmarkJobPosting(id))}>
            {isBookmarked ? <BookmarkIcon /> : <BookmarkBorderIcon />}
            Bookmark
        </Button>
    );
}
const useStyles = makeStyles(theme => ({
    chip: {
        '&.MuiChip-root': {
            padding: '6px 16px',
            borderRadius: 5,
            textTransform: 'uppercase',
        },
    },
    button: {
        '&.MuiButton-root .MuiSvgIcon-root': {
            paddingRight: theme.spacing(1),
        },
    },
}));