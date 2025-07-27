import React, { Component } from 'react';
import Post from './Post';

class Posts extends Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      hasError: false,
    };
  }
  componentDidMount() {
    this.loadPosts();
  }

  loadPosts = async () => {
    try {
      const response = await fetch('https://jsonplaceholder.typicode.com/posts');
      const data = await response.json();
      this.setState({ posts: data.slice(0, 10) }); 
    } catch (error) {
      this.setState({ hasError: true });
    }
  };

  componentDidCatch(error, info) {
    alert('An error occurred: ' + error.message);
  }

  render() {
    if (this.state.hasError) {
      return <h2>Error loading posts.</h2>;
    }

    return (
      <div>
        <h1>Latest Blog Posts</h1>
        {this.state.posts.map((post) => (
          <Post key={post.id} title={post.title} body={post.body} />
        ))}
      </div>
    );
  }
}

export default Posts;
