import React from 'react';
import './App.css';
import { Link } from 'react-router-dom';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <div>
          <h1>Concessionária: Test-Drive</h1>
        </div>

        <div className="Login">
          <div>
            <label>Email:</label>
            <input type="text"/>  
          </div>
          <div>
            <label>Senha:</label>
            <input type="password"/>  
          </div>
          <button><Link to="/Cadastrar">Cadastrar</Link></button>
          <button>Login</button>  
        </div>        
      </header>
    </div>
  );
}

export default App;
