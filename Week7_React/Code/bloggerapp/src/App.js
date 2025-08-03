import React from 'react';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';

function App() {
  return (
    <div style={{ padding: '30px', fontFamily: 'Arial' }}>
      <h1 style={{ textAlign: 'center' }}>React App</h1>
      <div style={{ display: 'flex', justifyContent: 'space-around', marginTop: '30px' }}>
        <div style={{ borderRight: '4px solid green', paddingRight: '20px' }}>
          <CourseDetails />
        </div>
        <div style={{ borderRight: '4px solid green', padding: '0 20px' }}>
          <BookDetails />
        </div>
        <div style={{ paddingLeft: '20px' }}>
          <BlogDetails />
        </div>
      </div>
    </div>
  );
}

export default App;
