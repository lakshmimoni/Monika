import React, { useState, useEffect } from 'react';
import Cube from './Components/Cube';
import axios from 'axios';

const App = () => {
  const [cubeCases, setCubeCases] = useState([]);
  const [zLock, setZLock] = useState(false);

  useEffect(() => {
    axios
      .get('/api/cubecases')
      .then((response) => setCubeCases(response.data))
      .catch((error) => console.error(error));
  }, []);

  const toggleZLock = () => {
    setZLock(!zLock);
  };

  return (
    <div>
      <h1>3D Cube with Z-Lock</h1>
      <button onClick={toggleZLock}>
        {zLock ? 'Unlock Z-axis' : 'Lock Z-axis'}
      </button>
      <Cube zLock={zLock} />
      <div>
        <h2>Cube Cases</h2>
        <ul>
          {cubeCases.map((cubeCase) => (
            <li key={cubeCase.id}>
              Width: {cubeCase.width}, Length: {cubeCase.length}, Height:{' '}
              {cubeCase.height}
            </li>
          ))}
        </ul>
      </div>
    </div>
  );
};

export default App;
