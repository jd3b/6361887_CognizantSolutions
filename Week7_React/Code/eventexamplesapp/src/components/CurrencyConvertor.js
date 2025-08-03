// src/components/CurrencyConvertor.js
import React, { useState } from 'react';

function CurrencyConvertor() {
  const [rupees, setRupees] = useState('');
  const [euros, setEuros] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    const converted = (parseFloat(rupees) / 88.5).toFixed(2);
    setEuros(converted);
  };

  return (
    <div>
      <h2>Currency Convertor (INR ➡ EUR)</h2>
      <form onSubmit={handleSubmit}>
        <label>
          Amount in ₹ INR:
          <input
            type="number"
            value={rupees}
            onChange={(e) => setRupees(e.target.value)}
            required
            style={{ marginLeft: '10px' }}
          />
        </label>
        <button type="submit" style={{ marginLeft: '10px' }}>
          Convert
        </button>
      </form>
      {euros && (
        <p>
          💶 Euros: <strong>{euros}</strong>
        </p>
      )}
    </div>
  );
}

export default CurrencyConvertor;
