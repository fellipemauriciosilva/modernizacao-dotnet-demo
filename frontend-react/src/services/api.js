import axios from 'axios';

const api = axios.create({
  baseURL: 'https://localhost:5001/api' // ajuste se necessário
});

export default api;
