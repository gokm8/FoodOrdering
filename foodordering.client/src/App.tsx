import { useState, useEffect } from 'react'
import './App.css'



type MenuItem = {
  id: number
  name: string
  description: string | null
  price: number
}

function App() {
  const [data, setData] = useState<MenuItem[]>([])

  useEffect(() => {
    fetch('/api/menu')
      .then(res => {
        if (!res.ok) {
          throw new Error('Kunne ikke hente menuen')
        }

        return res.json()
      })
      .then((items: MenuItem[]) => setData(items))
      .catch(error => console.error(error))
  }, [])

  return (
    <>
      <pre>{JSON.stringify(data, null, 2)}</pre>
    </>
  )
}

export default App
