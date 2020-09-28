import React from 'react';
import './inicialsc.css';
import { Link } from 'react-router-dom';

function App() {
  return (
    <div className="App">
        <div>
            <h1>Concessionária: Test-Drive</h1>
        </div>
        <div className="login">
            <div>
                <Link to="/Cadastrar">Cadastrar</Link>
            </div>
            <div>
                <Link to="/Login">Login</Link>
            </div>
        </div>
      <header className="App-header">
         <div> 
            <p>kajsakjsaksjaksjak sjakjs akdhaj dhw uhwud he eud hued huehdue hueuehudhue 
                udehudheuh uehduehduehdueakjsasjaksjaksjaksja sjksjaks jakjsaksjwi jdieee
                ekjdkjaksjak jeijijqokslaks lkeo keo kqpoqoekqok qlkqlkeqlkeqlklkqelkqelk</p>
        </div>
      </header>
    </div>
  );
}

export default App;