import { useState } from 'react';
import Button from '@mui/material/Button';
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

function SliderComponent() {}


function SubmitButton() {

  function handleClick() {
    alert('You have clicked Submit');
  }

  return (
    <div>
      <Button variant="contained"> Submit </Button>
    </div>
  );
}

function DisplaySavingsComponent() {

}
