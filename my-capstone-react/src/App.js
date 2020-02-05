import React from 'react';
import logo from './logo.svg';
import './App.css';
import logo1 from './logo.svg';
import WordForm from "./WordForm";

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <img src={logo1} className="App-logo1" alt="logo" />
        <h1>Hiroyuki-Hood English Quiz App</h1>       
      </header>
      <p class="par">Please enter a English word or a Spanish word in all lower caps <br/>
      <WordForm />
      </p>
      
    </div>
  );
}

export default App;
