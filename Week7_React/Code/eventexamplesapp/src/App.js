import React, { useState } from 'react';
import CurrencyConvertor from './components/CurrencyConvertor';

function App() {
  const [count, setCount] = useState(0);

  const sayHello = () => {
    alert('Hello! Have a nice day 🌟');
  };

  const handleIncrement = () => {
    setCount(prev => prev + 1);
    sayHello(); 
  };

  const handleDecrement = () => {
    setCount(prev => prev - 1);
  };

  const sayWelcome = (message) => {
    alert(`Welcome message: ${message}`);
  };

  const handleSyntheticClick = (event) => {
    alert('I was clicked');
    console.log('SyntheticEvent:', event);
  };

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      <h1>React Event Handling Example</h1>

      <h2>Counter: {count}</h2>
      <button onClick={handleIncrement}>Increment</button>
      <button onClick={handleDecrement} style={{ marginLeft: '10px' }}>
        Decrement
      </button>

      <hr />

      <button onClick={() => sayWelcome('welcome')} style={{ marginRight: '10px' }}>
        Say Welcome
      </button>

      <button onClick={handleSyntheticClick}>Click on me</button>

      <hr />

      <CurrencyConvertor />
    </div>
  );
}

export default App;
