import React, { useEffect, useState } from 'react';
import axios from 'axios';

function Booklist() {
  const [books, setBooks] = useState([]);

  useEffect(() => {
    const fetchBooks = async () => {
      try {
        const response = await axios.get('https://localhost:7259/api/Libraries');
        setBooks(response.data);
      } catch (error) {
        console.error('Error fetching the books:', error);
      }
    };

    fetchBooks();
  }, []);

  return (
    <div style={styles.container}>
      <h1>Book List</h1>
      <div style={styles.bookList}>
        {books.map((book) => (
          <div key={book.id} style={styles.bookCard}>
            <img src={book.imageUrl} alt={book.title} style={styles.image} />
            <h2>{book.title}</h2>
            <p>{book.description}</p>
            <p><strong>Published:</strong> {book.publicationYear}</p>
          </div>
        ))}
      </div>
    </div>
  );
}

const styles = {
  container: {
    padding: '20px',
    textAlign: 'center',
  },
  bookList: {
    display: 'flex',
    flexWrap: 'wrap',
    justifyContent: 'center',
  },
  bookCard: {
    border: '1px solid #ccc',
    borderRadius: '8px',
    margin: '10px',
    padding: '10px',
    width: '200px',
    boxShadow: '2px 2px 12px rgba(0, 0, 0, 0.1)',
  },
  image: {
    width: '100%',
    height: 'auto',
    borderRadius: '4px',
  },
};

export default Booklist;
