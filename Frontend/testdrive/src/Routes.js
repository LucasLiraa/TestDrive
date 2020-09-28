import React from 'react';
import {BrowserRouter, Switch, Route} from 'react-router-dom';

import InicialSemCadastro from './Pages/InicialSC'
import Login from './Pages/Login'
import InicialComCadastro from './Pages/InicialCC'
import Cadastrar from './Pages/Cadastrar'

export default function Routes() {
    
    return(
        <BrowserRouter>
            <Switch>
                <Route path="/" exact={true} component={InicialSemCadastro} />
                <Route path="/Login" component={Login} />
                <Route path="/Inicial" component={InicialComCadastro} />
                <Route path="Cadastrar" component={Cadastrar} />
            </Switch>
        </BrowserRouter>
    )
}