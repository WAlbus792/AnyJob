import React from 'react';
import { Checkbox, List, ListItem, ListItemIcon, ListItemText } from "@mui/material";
import { useDispatch, useSelector } from "react-redux";
import { searchStore } from "../../../store";

export default function LocationsCheckboxList() {
    const locations = useSelector(searchStore.selectLocations);
    const selected = useSelector(searchStore.selectAdvancedFiltersLocations);
    const dispatch = useDispatch();
    
    const handleToggle = value => () => {
        const currentIndex = selected.indexOf(value);
        const newSelected = [...selected];
        
        if (currentIndex === -1) {
            newSelected.push(value);
        } else {
            newSelected.splice(currentIndex, 1);
        }
        
        dispatch(searchStore.setAdvancedFiltersLocations(newSelected));
        dispatch(searchStore.getJobPostings());
    };
    
    return (
        <List sx={{ maxHeight: 300, overflow: 'auto', }} dense component="div" role="list">
            {locations.map(({ id, name }) => (
                <ListItem key={id} role="listitem" button onClick={handleToggle(id)}>
                    <ListItemIcon>
                        <Checkbox checked={selected.indexOf(id) !== -1} tabIndex={-1} disableRipple />
                    </ListItemIcon>
                    <ListItemText id={`advanced-filters-location-${id}-label`} primary={name} />
                </ListItem>
            ))}
        </List>
    );
}