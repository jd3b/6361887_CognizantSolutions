import React from 'react';

const IndianPlayers = () => {
  const oddPlayers = ['Sachin1', 'Virat3', 'Yuvaraj5'];
  const evenPlayers = ['Dhoni2', 'Rohit4', 'Raina6'];

  const T20players = [
    'Mr. First Player',
    'Mr. Second Player',
    'Mr. Third Player',
  ];
  const RanjiPlayers = [
    'Mr. Fourth Player',
    'Mr. Fifth Player',
    'Mr. Sixth Player',
  ];

  const allPlayers = [...T20players, ...RanjiPlayers];

  return (
    <div>
      <h2>Odd Players</h2>
      <ul>
        <li>First : {oddPlayers[0]}</li>
        <li>Third : {oddPlayers[1]}</li>
        <li>Fifth : {oddPlayers[2]}</li>
      </ul>

      <h2>Even Players</h2>
      <ul>
        <li>Second : {evenPlayers[0]}</li>
        <li>Fourth : {evenPlayers[1]}</li>
        <li>Sixth : {evenPlayers[2]}</li>
      </ul>

      <h2>List of Indian Players Merged:</h2>
      <ul>
        {allPlayers.map((p, i) => (
          <li key={i}>{p}</li>
        ))}
      </ul>
    </div>
  );
};

export default IndianPlayers;
