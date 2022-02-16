import React from 'react';
import { Box, Grid, Typography } from "@mui/material";
import { makeStyles } from "@mui/styles";
import jobIcon from '../../assets/job-icon.png';
import AccessTimeIcon from '@mui/icons-material/AccessTime';
import LocationOnIcon from '@mui/icons-material/LocationOn';
import { JobPostingApplyButton, JobPostingBookmarkButton } from "./ActionButtons";

export default function JobPostingDataItem({ data }) {
    const classes = useStyles();
    
    return (
        <Box className={classes.root}>
            <Grid container alignItems="center">
                <Grid item xs={2} className={classes.icon}>
                    <img src={jobIcon} alt="job icon" />
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
                    <JobPostingBookmarkButton id={data.id} />
                    <JobPostingApplyButton item={data} />
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
            
            '& > * + *': {
                marginTop: theme.spacing(1),
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
        },
    },
}));