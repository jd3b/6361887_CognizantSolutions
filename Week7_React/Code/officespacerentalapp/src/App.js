import React from 'react';

function App() {
  const heading = <h1>Office Space Rental Listings</h1>;
  const image = (
    <img
      src="https://plus.unsplash.com/premium_photo-1661931749081-23d69ddb62d1?q=80&w=1883&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
      alt="Office Space"
      style={{ width: '400px', height: '200px' }}
    />
  );

  const office = {
    name: 'SkyView Tower',
    rent: 75000,
    address: 'MG Road, Bangalore',
  };

  const officeList = [
    { name: 'SkyView Tower', rent: 75000, address: 'MG Road, Bangalore' },
    { name: 'TechHub Plaza', rent: 55000, address: 'HSR Layout, Bangalore' },
    { name: 'GreenWorks', rent: 60000, address: 'Indiranagar, Bangalore' },
  ];

  const getRentStyle = (rent) => ({
    color: rent < 60000 ? 'red' : rent > 60000 ? 'green' : 'black',
    fontWeight: 'bold',
  });

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      {heading}
      {image}

      <h2>Featured Office</h2>
      <p><strong>Name:</strong> {office.name}</p>
      <p><strong>Rent:</strong> <span style={getRentStyle(office.rent)}>{office.rent}</span></p>
      <p><strong>Address:</strong> {office.address}</p>

      <h2>Available Offices</h2>
      <ul>
        {officeList.map((item, index) => (
          <li key={index}>
            <p><strong>Name:</strong> {item.name}</p>
            <p><strong>Rent:</strong> <span style={getRentStyle(item.rent)}>{item.rent}</span></p>
            <p><strong>Address:</strong> {item.address}</p>
            <hr />
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
