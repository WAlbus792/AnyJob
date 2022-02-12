import React from 'react';
import { Accordion, AccordionDetails, AccordionSummary, Box, Typography } from "@mui/material";
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';
import CategoriesCheckboxList from "./CategoriesCheckboxList";
import LocationsCheckboxList from "./LocationsCheckboxList";
import EmploymentTypesCheckboxList from "./EmploymentTypesCheckboxList";

export default function AdvancedFilters() {
    
    return (
        <Box>
            <Accordion>
                <AccordionSummary expandIcon={<ExpandMoreIcon />} id="categories-panel-header">
                    <Typography>Categories</Typography>
                </AccordionSummary>
                <AccordionDetails>
                    <CategoriesCheckboxList />
                </AccordionDetails>
            </Accordion>
            <Accordion defaultExpanded>
                <AccordionSummary expandIcon={<ExpandMoreIcon />} id="employment-type-panel-header">
                    <Typography>Employment Type</Typography>
                </AccordionSummary>
                <AccordionDetails>
                    <EmploymentTypesCheckboxList />
                </AccordionDetails>
            </Accordion>
            <Accordion>
                <AccordionSummary expandIcon={<ExpandMoreIcon />} id="location-panel-header">
                    <Typography>Location</Typography>
                </AccordionSummary>
                <AccordionDetails>
                    <LocationsCheckboxList />
                </AccordionDetails>
            </Accordion>
        </Box>
    );
}