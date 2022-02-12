import React, { useState } from 'react';
import { Button, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle } from "@mui/material";
import WorkIcon from "@mui/icons-material/Work";
import { makeStyles } from "@mui/styles";

export default function JobPostingApplyButton({ item }) {
    const classes = useStyles();
    const [open, setOpen] = useState(false);
    
    const handleClose = () => setOpen(false);
    
    return (
        <>
            <Button className={classes.button} variant="contained" color="success" onClick={() => setOpen(true)}>
                <WorkIcon />
                Apply For This Job
            </Button>
            <Dialog
                open={open}
                onClose={handleClose}
                scroll="paper"
            >
                <DialogTitle id="job-posting-title">{item.title}</DialogTitle>
                <DialogContent dividers={true}>
                    <DialogContentText
                        id={`job-posting-${item.id}-details`}
                        // ref={descriptionElementRef}
                        tabIndex={-1}
                    >
                        {[...new Array(5)]
                            .map(() => `Cras mattis consectetur purus sit amet fermentum.
Cras justo odio, dapibus ac facilisis in, egestas eget quam.
Morbi leo risus, porta ac consectetur ac, vestibulum at eros.
Praesent commodo cursus magna, vel scelerisque nisl consectetur et.`,
                            )
                            .join('\n')}
                    </DialogContentText>
                </DialogContent>
                <DialogActions>
                    <Button onClick={handleClose}>Cancel</Button>
                    <Button variant="contained" color="success" onClick={handleClose}>Apply</Button>
                </DialogActions>
            </Dialog>
        </>
    );
}
const useStyles = makeStyles(theme => ({
    button: {
        '&.MuiButton-root .MuiSvgIcon-root': {
            paddingRight: theme.spacing(1),
        },
    },
}));