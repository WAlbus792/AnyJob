import React  from 'react';
import { FormControl, InputLabel, MenuItem, Select } from "@mui/material";
import { useDispatch, useSelector } from "react-redux";
import { searchStore } from "../../../store";

const CategorySelect = () => {
    const categories = useSelector(searchStore.selectCategories);
    const selected = useSelector(searchStore.selectSearchBoxCategory);
    const dispatch = useDispatch();
    
    return (
        <FormControl variant="filled" size="small" fullWidth sx={{ borderRight: "1px solid grey" }}>
            <InputLabel id="job-category-select-label">Job Category</InputLabel>
            <Select
                labelId="job-category-select-label"
                id="job-category-select"
                value={selected ? selected : ""}
                onChange={e => dispatch(searchStore.setSearchBoxCategory(e.target.value))}
                label="Job Category"
            >
                {categories.map(c => <MenuItem key={c.id} value={c}>{c.name}</MenuItem>)}
            </Select>
        </FormControl>
    );
};

export default CategorySelect;