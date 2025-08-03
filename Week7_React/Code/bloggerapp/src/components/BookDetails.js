import React from 'react';

function BookDetails() {
  const books = [
    { id: 1, title: 'Master React', price: '670' },
    { id: 2, title: 'Deep Dive into Angular 11', price: '800' },
    { id: 3, title: 'Mongo Essentials', price: '450' },
  ];

  return (
    <div>
      <h2>Book Details</h2>
      {books.map(book => (
        <div key={book.id}>
          <h3>{book.title}</h3>
          <p>{book.price}</p>
        </div>
      ))}
    </div>
  );
}

export default BookDetails;
