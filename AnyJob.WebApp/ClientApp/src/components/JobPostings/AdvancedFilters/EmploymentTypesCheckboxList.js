import React from 'react';
import { Checkbox, List, ListItem, ListItemIcon, ListItemText } from "@mui/material";
import { useDispatch, useSelector } from "react-redux";
import { searchStore } from "../../../store";

export default function EmploymentTypesCheckboxList() {
    const employmentTypes = useSelector(searchStore.selectEmploymentTypes);
    const selected = useSelector(searchStore.selectAdvancedFiltersEmploymentTypes);
    const dispatch = useDispatch();
    
    const handleToggle = value => () => {
        const currentIndex = selected.indexOf(value);
        const newSelected = [...selected];
        
        if (currentIndex === -1) {
            newSelected.push(value);
        } else {
            newSelected.splice(currentIndex, 1);
        }
        
        dispatch(searchStore.setAdvancedFiltersEmploymentTypes(newSelected));
        dispatch(searchStore.getJobPostings());
    };
    
    return (
        <List sx={{ maxHeight: 300, overflow: 'auto' }} dense component="div" role="list">
            {employmentTypes.map(({ id, name }) => (
                <ListItem key={id} role="listitem" button onClick={handleToggle(id)}>
                    <ListItemIcon>
                        <Checkbox checked={selected.indexOf(id) !== -1} tabIndex={-1} disableRipple />
                    </ListItemIcon>
                    <ListItemText id={`advanced-filters-employment-type-${id}-label`} primary={name} />
                </ListItem>
            ))}
        </List>
    );
}