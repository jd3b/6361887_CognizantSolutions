import React from 'react';
import '../Stylesheets/mystyle.css';

function CalculateScore() {
  const name = "Steeve";
  const school = "DNV Public School";
  const totalMarks = 284;
  const maxMarks = 300;
  const score = ((totalMarks / maxMarks) * 100).toFixed(2);

  return (
    <div className="student-container">
      <h1 className="heading">Student Details:</h1>
      <p><span className="label name">Name:</span> {name}</p>
      <p><span className="label school">School:</span> {school}</p>
      <p><span className="label total">Total:</span> {totalMarks} Marks</p>
      <p><span className="label score">Score:</span>{score}%</p>
    </div>
  );
}

export default CalculateScore;
