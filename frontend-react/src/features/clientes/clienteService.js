import api from '../../services/api';

export const getClientes = () => api.get('/clientes');
export const salvarCliente = (cliente) => api.post('/clientes', cliente);
