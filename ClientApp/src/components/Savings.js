import { useState } from 'react';
import './Savings.css';

export function Savings() {
  return (
    <div>
      <SubmitButton />
      <SliderComponent />
      <DisplaySavingsComponent />
    </div>
  );
}

function SliderComponent() {
  var slider = document.getElementById("myRange");
  var output = document.getElementById("demo");
  output.innerHTML = slider.value; // Display the default slider value
  
  // Update the current slider value (each time you drag the slider handle)
  function sliderInput() {
    output.innerHTML = this.value;
  }

  return(
    <div class="slidecontainer">
      <input type="range" min="1" max="100" value="50" class="slider" id="myRange" onInput={sliderInput}/>
    </div>
  );

}
function SubmitButton() {
  const [count, setCount] = useState(0);

  function handleClick() {
    setCount(count + 1);
  }

  return (
    <button onClick={handleClick}>
      Submit
    </button>
  );
}

function DisplaySavingsComponent() {

}
