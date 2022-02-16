import React from 'react';
import { Box, Button, Grid, Typography } from "@mui/material";
import { makeStyles } from "@mui/styles";
import jobIcon from '../../assets/job-icon.png';
import AccessTimeIcon from '@mui/icons-material/AccessTime';
import LocationOnIcon from '@mui/icons-material/LocationOn';
import { useSelector } from "react-redux";
import { authStore } from "../../store";
import BookmarkBorderIcon from '@mui/icons-material/BookmarkBorder';
import BookmarkIcon from '@mui/icons-material/Bookmark';
import WorkIcon from '@mui/icons-material/Work';

export default function JobPostingDataItem({ data }) {
    const classes = useStyles();
    const bookmarks = useSelector(authStore.selectUserBookmarks);
    const isBookmarked = bookmarks.includes(data.id);
    
    return (
        <Box className={classes.root}>
            <Grid container alignItems="center">
                <Grid item xs={2} className={classes.icon}>
                    <picture>
                        <img src={jobIcon} alt="job icon" />
                    </picture>
                </Grid>
                <Grid item xs={6}>
                    <Typography paragraph><strong> {data.title}</strong></Typography>
                    <Typography variant="subtitle2" className={classes.description}>
                        <LocationOnIcon /> {data.location}
                    </Typography>
                    <Typography variant="subtitle2" className={classes.description}>
                        <AccessTimeIcon /> {data.employmentType}
                    </Typography>
                </Grid>
                <Grid xs={4} item className="actions">
                    <Button variant="contained" color="primary" disabled={isBookmarked}>
                        {isBookmarked ? <BookmarkIcon /> : <BookmarkBorderIcon />}
                        Bookmark
                    </Button>
                    <Button variant="contained" color="success">
                        <WorkIcon />
                        Apply For This Job
                    </Button>
                </Grid>
            </Grid>
        </Box>
    );
};

const useStyles = makeStyles(theme => ({
    root: {
        padding: theme.spacing(2),
        border: '1px solid #d3d3d3',
        
        "& .actions": {
            flexDirection: 'column',
            alignItems: 'end',
            display: 'flex',
            
            '& > button': {
                '& + button': {
                    marginTop: theme.spacing(1),
                },
                
                '& .MuiSvgIcon-root': {
                    paddingRight: theme.spacing(1),
                },
            },
        },
    },
    icon: {
        paddingRight: theme.spacing(2),
        
        '& img': {
            width: '100%',
        },
    },
    description: {
        color: '#8f8f8f',
        display: 'inline-flex',
        alignItems: 'center',
        
        '& + &': {
            marginLeft: theme.spacing(1),
        }
    },
}));