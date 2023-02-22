import { useState } from 'react';
import Button from '@mui/material/Button';
import { TextField } from '@mui/material';
import './Savings.css';

export function Savings() {
  return (
    <div>
      <SliderComponent />
      <SubmitButton />
      <DisplaySavingsComponent />
    </div>
  );
}

function SliderComponent() {
  return (
  <div class="slider_component">
    <TextField id="outlined-basic" label="Borrowing Amount" variant="outlined" />
  </div>
  );
}

function SubmitButton() {

  function handleClick() {
    alert('You have clicked Submit');
  }

  return (
    <div>
      <Button variant="contained" onClick={handleClick}> Submit </Button>
    </div>
  );
}

function DisplaySavingsComponent() {
  return (
    <div class="display_component">
      <TextField id="outlined-basic" label="Savings Amount" variant="outlined" />
    </div>
    );
}
