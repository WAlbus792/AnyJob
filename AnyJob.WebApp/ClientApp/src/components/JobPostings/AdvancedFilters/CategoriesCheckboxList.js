import React from 'react';
import { Checkbox, List, ListItem, ListItemIcon, ListItemText } from "@mui/material";
import { useDispatch, useSelector } from "react-redux";
import { searchStore } from "../../../store";

export default function CategoriesCheckboxList() {
    const categories = useSelector(searchStore.selectCategories);
    const selected = useSelector(searchStore.selectAdvancedFiltersCategories);
    const dispatch = useDispatch();
    
    const handleToggle = value => () => {
        const currentIndex = selected.indexOf(value);
        const newSelected = [...selected];
        
        if (currentIndex === -1) {
            newSelected.push(value);
        } else {
            newSelected.splice(currentIndex, 1);
        }
        
        dispatch(searchStore.setAdvancedFiltersCategories(newSelected));
        dispatch(searchStore.getJobPostings());
    };
    
    return (
        <List sx={{ maxHeight: 300, overflow: 'auto', }} dense component="div" role="list">
            {categories.map(({ id, name }) => (
                <ListItem key={id} role="listitem" button onClick={handleToggle(id)}>
                    <ListItemIcon>
                        <Checkbox checked={selected.indexOf(id) !== -1} tabIndex={-1} disableRipple />
                    </ListItemIcon>
                    <ListItemText id={`advanced-filters-category-${id}-label`} primary={name} />
                </ListItem>
            ))}
        </List>
    );
}