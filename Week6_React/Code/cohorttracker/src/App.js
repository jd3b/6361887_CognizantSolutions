import React from 'react';
import CohortDetails from './CohortDetails';

function App() {
  const cohort1 = {
    cohortCode: 'FS102',
    technology: 'React',
    startDate: '2024-07-01',
    currentStatus: 'ongoing',
    coachName: 'Anjali',
    trainerName: 'Ravi'
  };

  const cohort2 = {
    cohortCode: 'FS101',
    technology: 'Angular',
    startDate: '2024-06-01',
    currentStatus: 'completed',
    coachName: 'Vivek',
    trainerName: 'Sonal'
  };

  return (
    <div className="App">
      <h1>Cohort Dashboard</h1>
      <CohortDetails cohort={cohort1} />
      <CohortDetails cohort={cohort2} />
    </div>
  );
}

export default App;
