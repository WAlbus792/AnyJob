import React from 'react';
import { FormControl, InputLabel, MenuItem, Select } from "@mui/material";
import { useDispatch, useSelector } from "react-redux";
import { searchStore } from "../../../store";

const LocationSelect = () => {
    const locations = useSelector(searchStore.selectLocations);
    const selected = useSelector(searchStore.selectSearchBoxLocation);
    const dispatch = useDispatch();
    
    return (
        <FormControl variant="filled" size="small" fullWidth sx={{ borderRight: "1px solid grey" }}>
            <InputLabel id="job-location-select-label">Job Location</InputLabel>
            <Select
                labelId="job-location-select-label"
                id="job-location-select"
                value={selected ? selected : ""}
                label="Job Location"
                onChange={e => dispatch(searchStore.setSearchBoxLocation(e.target.value))}
            >
                {locations.map(c => <MenuItem key={c.id} value={c}>{c.name}</MenuItem>)}
            </Select>
        </FormControl>
    );
};

export default LocationSelect;